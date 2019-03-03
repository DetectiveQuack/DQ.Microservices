"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const http_1 = require("http");
const app = require('express')();
const server = http_1.createServer(app);
app.get('/api/values', function (req, res) {
    res.send('hello');
});
app.set('port', (process.env.PORT || 3000));
console.log('The port is:::: ', app.get('port'));
server.listen(app.get('port'), () => {
    console.log('---> listening on port ', app.get('port'));
});
//# sourceMappingURL=app.js.map
