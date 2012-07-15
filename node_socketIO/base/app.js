var connect = require('connect');

var port = process.env.PORT || 8000;

console.log("demo: Starting server on port " + port + "...");

var server = connect().use(connect.logger())
                      .use(connect.favicon()) 
                      .use(connect.static(__dirname + '/public'))
                      .listen(process.env.PORT || 8000);

