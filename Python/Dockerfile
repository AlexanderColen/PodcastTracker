FROM ubuntu:18.04

LABEL Author 'Alexander Colen'

# Fix timezone, without this it would be set to UTC.
ENV TZ 'America/Toronto'
RUN echo $TZ > /etc/timezone && \
    apt-get update && apt-get install -y tzdata && \
    rm /etc/localtime && \
    ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && \
    dpkg-reconfigure -f noninteractive tzdata && \
    apt-get clean

# Install Python3.
RUN apt-get update && \
    apt-get install python3 python3-pip -y

# Install all dependencies.
COPY pip-dependencies.txt pip-dependencies.txt
RUN pip3 install -r pip-dependencies.txt 

# Start up script.
COPY DB DB
COPY Model Model
COPY RSS RSS
COPY main.py main.py
RUN chmod +x main.py