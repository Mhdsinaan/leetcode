var isPalindrome = function(s) {
    var values=s.toLowerCase().replace(/[^a-z0-9]/g,"")
    return values==values.split("").reverse().join("")
      
  
      
  };
  console.log(isPalindrome("A man, a plan, a canal: Panama"));