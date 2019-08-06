import math


class Podcast:
    def __init__(self, uuid, title, description, duration, published, **kwargs):
        self.uuid = uuid
        self.title = title
        self.description = description

        try:
            # Duration is in seconds, thus format it to hh:mm:ss.
            self.duration_raw = int(duration)
            dur_hr = '{:0<2d}'.format(math.floor(int(duration) / 3600))
            dur_min = '{:0>2d}'.format(math.floor(int(duration) / 60))
            dur_sec = '{:0<2d}'.format(int(duration) % 60)
            self.duration_formatted = f'{dur_hr}:{dur_min}:{dur_sec}'
        except ValueError:
            # Duration is already in proper format.
            self.duration_raw = duration
            self.duration_formatted = duration
        self.date = published

        self.explicit = kwargs.get('explicit', None)
        self.image = kwargs.get('image_url', None)

    def __str__(self):
        return f'ID: {self.uuid} \n' \
               f'Title: {self.title}\n' \
               f'Description: {self.description}\n' \
               f'Duration: {self.duration_formatted} ({self.duration_raw})\n' \
               f'Date: {self.date}\n' \
               f'Explicit: {self.explicit}\n' \
               f'Image: {self.image}'