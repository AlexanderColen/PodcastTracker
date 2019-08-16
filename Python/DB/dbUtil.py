from pymongo import MongoClient
import datetime
import feedparser
import unicodedata


class DbUtil:
    @staticmethod
    def connect():
        client = MongoClient('mongodb://podcast-db:27017/')
        db = client['tracker']
        return db

    @staticmethod
    def get_rss_feeds():
        db = DbUtil.connect()
        return db.rss.find({})

    @staticmethod
    def get_episodes():
        db = DbUtil.connect()
        return db.episode.find({})

    @staticmethod
    def update_names():
        db = DbUtil.connect()
        rss_feeds = db.rss.find({})

        for record in rss_feeds:
            if (not record['name']):
                feed = feedparser.parse(url_file_stream_or_string=record['rss'])
                db.rss.find_one_and_update({'rss': record['rss']}, { '$set': {'name': feed.channel.title, 'lastRefresh': datetime.datetime.now()}})
                print(f'Updated {feed.channel.title}')

    @staticmethod
    def add_podcast_episodes(episodes):
        db = DbUtil.connect()

        new = 0
        duplicates = 0
        for episode in episodes:
            # TODO Check if episodes already exists.
            found = False
            # foundEpisode = db.episode.find({'title': episode.title, 'description': episode.description, 'date': episode.date})
            # If not, insert the episode into the database.
            if (not found):
                new += 1
                db.episode.insert_one({'uuid': episode.uuid,
                                       'title': episode.title,
                                       'description': episode.description,
                                       'duration_raw': episode.duration_raw,
                                       'duration_formatted': episode.duration_formatted,
                                       'date': episode.date,
                                       'explicit': episode.explicit,
                                       'image': episode.image})
            else:
                duplicates += 1

        print(f'{new} new and {duplicates} duplicate episodes found.')
                                       
        # TODO Update last refresh for RSS table.