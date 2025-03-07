function truncateSentence(s, k) {
    const words = s.split(' ');
    const truncatedWords = words.slice(0, k);
    const result = truncatedWords.join(' ');

    return result;
}
console.log(truncateSentence("sinan muhammed areekode",2));