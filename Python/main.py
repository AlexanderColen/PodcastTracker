#!/usr/bin/env python3
from DB.dbUtil import DbUtil


if __name__ == '__main__':
    # Updates names of RSS feeds if they are missing.
    DbUtil.update_names()
    
