var connect = require('connect');
var monkey = require('./monkey');

var port = process.env.PORT || 8000;
console.log('Starting server on port ' + port);

var routes = function (app) {
	app.get('/monkey/:action/:command', function(req, res, next) {
		if (req.params.action === 'say') {
			res.write(monkey.say(req.params.command));
			res.end();
		} else if(req.params.action === 'do') {
			res.write(monkey.do(req.params.command));
			res.end();
		} else {
			return next();
		}
	});
};

var server = connect()
	.use(connect.logger())
	.use(connect.favicon())
	.use(connect.directory(__dirname + '/public'))
	.use(connect.static(__dirname + '/public'))
	.use(connect.router(routes))
	.listen(port);


