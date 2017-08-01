let R = require("ramda");
let f = R.pipe(R.reverse, R.tail, R.head)
let a = f([1,2,3,4,5])
console.log(a);