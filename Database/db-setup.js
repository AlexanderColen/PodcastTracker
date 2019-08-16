var file = cat('./rss-feeds.txt');
var podcasts = file.split('\n');

for (var i = 0; i < podcasts.length; i++) {
    // Insert unique values into database.
    foundFeed = db.rss.find({'rss': podcasts[i]})
    if (foundFeed.count() === 0) {
        db.rss.save({name: '', rss: podcasts[i], lastRefresh: Date()});
    }
}