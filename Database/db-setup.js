var file = cat('./rss-feeds.txt');
var podcasts = file.split('\n');

for (var i = 0; i < podcasts.length; i++) {
    // Insert value into database.
    db.rss.save({name: '', rss: podcasts[i], lastRefresh: Date()});
}