FROM mongo:latest

LABEL Author 'Alexander Colen'

COPY ./db-setup.js ./db-setup.js
COPY ./rss-feeds.txt ./rss-feeds.txt

# RUN mongo tracker db-setup.js