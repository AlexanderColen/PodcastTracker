#!/usr/bin/env python3
from DB.dbUtil import DbUtil
from RSS.reader import RssReader
from datetime import datetime, timedelta
import time


if __name__ == '__main__':
    # TODO Make it possible to set interval via command line parameter.
    interval = 3600
    loops = 0
    while True:
        loops += 1
        print(f'Starting loop #{loops}')
        # Updates names of RSS feeds if they are missing.
        DbUtil.update_names()
        
        # Get and insert the podcast episodes for all podcasts.
        feeds = DbUtil.get_rss_feeds()
        for feed in feeds:
            print('')
            print((f'Currently fetching: {feed["name"]}').encode('utf-8'))
            episodes = RssReader.read_podcast_rss(rss_url=feed["rss"])
            DbUtil.add_podcast_episodes(episodes=episodes, feed_id=feed["_id"])

        print('')
        print('====================================================')
        print(f'Loop #{loops} finished.')
        print(f'Current time: {datetime.now()}')
        print(f'Next loop scheduled for: {datetime.now() + timedelta(seconds=interval)}')
        print('====================================================')
        print('')
        # Sleep for interval seconds and repeat so that this loop happens roughly once per interval seconds.
        time.sleep(interval)