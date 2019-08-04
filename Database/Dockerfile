FROM mongo:latest

LABEL Author 'Alexander Colen'

# Fix timezone, without this it would be set to UTC.
ENV TZ 'America/Toronto'
RUN echo $TZ > /etc/timezone && \
    apt-get update && apt-get install -y tzdata && \
    rm /etc/localtime && \
    ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && \
    dpkg-reconfigure -f noninteractive tzdata && \
    apt-get clean

# Copy required files for MongoDB setup.
COPY ./db-setup.js ./db-setup.js
COPY ./rss-feeds.txt ./rss-feeds.txt

RUN mongo tracker db-setup.js