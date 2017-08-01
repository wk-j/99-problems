
var R = require("ramda");
var a = [1,2,3,2,1];

var isP = (l) => R.equals(R.reverse(l),l);
console.log(isP(a));


