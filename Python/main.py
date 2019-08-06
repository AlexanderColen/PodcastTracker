#!/usr/bin/env python3

from pymongo import MongoClient
from pprint import pprint


if __name__ == '__main__':
    client = MongoClient('mongodb://podcast-db:27017/')
    db = client['tracker']

    serverStatusResult=db.command("serverStatus")
    pprint(serverStatusResult)
