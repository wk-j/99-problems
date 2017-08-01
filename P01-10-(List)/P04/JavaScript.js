{
    var R = require("ramda")
    var a = [1,2,3,4,5];
    var len = (ls) =>  R.length(ls);
    console.log(len(a));
}