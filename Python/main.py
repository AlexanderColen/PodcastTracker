#!/usr/bin/env python3
from DB.dbUtil import DbUtil
from RSS.reader import RssReader


if __name__ == '__main__':
    # Updates names of RSS feeds if they are missing.
    DbUtil.update_names()
    
    # TODO Convert this to a loop to run indefinitely.
    # Get and insert the podcast episodes for all podcasts.
    feeds = DbUtil.get_rss_feeds()
    for feed in feeds:
        print('')
        print((u'Currently fetching: ' + feed['name']).encode('utf-8'))
        episodes = RssReader.read_podcast_rss(feed['rss'])
        DbUtil.add_podcast_episodes(episodes)