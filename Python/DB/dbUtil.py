from pymongo import MongoClient
import feedparser
import unicodedata


class DbUtil:
    @staticmethod
    def connect():
        client = MongoClient('mongodb://podcast-db:27017/')
        db = client['tracker']
        return db

    @staticmethod
    def update_names():
        db = DbUtil.connect()
        rss_feeds = db.rss.find({})

        for record in rss_feeds:
            if (not record['name']):
                feed = feedparser.parse(url_file_stream_or_string=record['rss'])
                db.rss.find_one_and_update({'rss': record['rss']}, { '$set': {'name': feed.channel.title}})
                print(f'Updated {feed.channel.title}')

    @staticmethod
    def read_db():
        db = DbUtil.connect()
        rss_feeds = db.rss.find({})

        for record in rss_feeds:
            print(record)