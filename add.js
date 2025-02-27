function map(arr) {
    var newArr = []; 

    for (let i = 0; i < arr.length; i++) {
        newArr.push(arr[i] + 1);  
    }

    return newArr; 
}


console.log(map([1,2,3],(n)=>n+1))