var removeElement = function(nums, val) {
    let k = 0; 
    
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] !== val) {
            nums[k] = nums[i]; 
            k++; 
        }
    }
    
    return k; 
};
console.log(removeElement([1,2,3,2,1,3,2,6],2));

let k = removeElement(nums, val);
console.log(`Output: ${k}, nums = [${nums.slice(0, k).join(",")}, _, _, _]`);