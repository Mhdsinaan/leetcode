var reverseWords = function(s) {
    var words = s.split(' ');
    var reversedWords = words.map((word) => word.split('').reverse().join(''));
    var result = reversedWords.join(' ');
    return result;
};
console.log(reverseWords("hello world"));