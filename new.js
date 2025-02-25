let orginal={name:"sinan",details:{age:25}}
let copy=JSON.parse(JSON.stringify(orginal))
copy.name="muhammed"
copy.details.age=30
console.log(orginal);
console.log(copy);

 