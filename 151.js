var reverseWords = function(s) {
    let arr = s.split(" ");
    let filt = arr.filter((item) => item !== "")
    return filt.reverse().join(" ")
};

console.log(reverseWords("the sky is blue"))
console.log(reverseWords("a good   example"))
