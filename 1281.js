var subtractProductAndSum = function(n) {

    var values=n.toString().split("").map(Number);
    let multiplication=values.reduce((acc,num)=>acc*num,1);
    let sum=values.reduce((acc,num)=>acc+num,0);
    return multiplication-sum;
    
};
console.log(subtractProductAndSum(234));