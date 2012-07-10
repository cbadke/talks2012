var http = require('http');
var monkey = require('./monkey');

var server = http.createServer( function(req, res) {
	res.writeHead(200, {'Content-Type': 'text/plain'});

	if (req.url === '/say') {
		res.write(monkey.say('Hello!'));
	} else if (req.url === '/do') {
		res.write(monkey.do('walk'));
	} else {
		res.write('monkey no understand');
	}
	res.end();

});

server.listen(8000);
