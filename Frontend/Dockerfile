FROM nginx:latest

LABEL Author 'Alexander Colen'

# Fix timezone, without this it would be set to UTC.
ENV TZ 'America/Toronto'
RUN echo $TZ > /etc/timezone && \
    apt-get update && apt-get install -y tzdata && \
    rm /etc/localtime && \
    ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && \
    dpkg-reconfigure -f noninteractive tzdata && \
    apt-get clean

# Copy custom configuration file.
COPY ./nginx.conf /etc/nginx/conf.d/default.conf

# Copy application to NGINX hosted folder.
COPY ./App /usr/share/nginx/html