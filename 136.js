var reverse = function(x) {
    
    return parseInt( x.toString().split("").reverse().join("")) * Math.sign(x);
};

const x = -123;
console.log(reverse(x)); 
