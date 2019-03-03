import { createServer } from 'http';

const app = require('express')();
const server = createServer(app);

app.get('/api/node/test', function (req, res) {
    res.send('hello from node api');
});

app.set('port', (process.env.PORT || 3000));
console.log('The port is:::: ', app.get('port'));

server.listen(app.get('port'), () => {
    console.log('---> listening on port ', app.get('port'));
});
