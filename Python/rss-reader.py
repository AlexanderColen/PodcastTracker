import feedparser
from Model.podcast import Podcast


class RssReader:
    @staticmethod
    def read_podcast_rss(rss_url):
        podcast_feed = feedparser.parse(url_file_stream_or_string=rss_url)
        entries = podcast_feed.entries
        podcast_episodes = []
        for entry in entries:
            image = None
            explicit = None

            if 'image' in entry.keys():
                image = entry.image.href
            if 'itunes_explicit' in entry.keys():
                explicit = entry.itunes_explicit

            ep = Podcast(uuid=entry.id,
                         title=entry.title,
                         description=entry.summary_detail.value,
                         duration=entry.itunes_duration,
                         published=entry.published,
                         explicit=explicit,
                         image_url=image)
            podcast_episodes.append(ep)

        return podcast_episodes