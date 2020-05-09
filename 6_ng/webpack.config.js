const path = require('path');

module.exports = {
  entry: './ts/out/app.js',
  output: {
    path: path.resolve(__dirname, 'ts/dist'),
    filename: 'bundle.js'
  }
};