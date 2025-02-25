function map(arr) {
    var newArr = [];  // Create an empty array to store results

    for (let i = 0; i < arr.length; i++) {
        newArr.push(arr[i] + 1);  // Store computed value
    }

    return newArr;  // Return the new array
}

// Example usage:
console.log(map([1,2,3],(n)=>n+1))