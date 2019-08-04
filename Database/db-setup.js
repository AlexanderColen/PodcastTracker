var file = cat('./rss-feeds.txt');
var podcasts = file.split('\n');

for (var i = 0; i < podcasts.length; i++) {
    // Remove \r from the end of the string.
    if (podcasts[i].indexOf("\r") >= 0) {
        podcasts[i] = podcasts[i].replace("\r", "");
    }

    // Insert value into database.
    db.rss.save({name: '', rss: podcasts[i], lastRefresh: Date()});
}