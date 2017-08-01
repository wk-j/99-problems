{
    let a = [1,1,2,3,5,8]
    console.log(a[a.length - 1] == 8);
    console.log(a.reverse()[0] == 8);
    console.log(a.reduceRight((acc, x) => x) == 8);
}