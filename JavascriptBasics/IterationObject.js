
/* This is basic loop section start */

const arr = ['a','b','c','d'];

for(let i = 0; i < arr.length; i++){
    console.log('arr['+ i +']: ' + arr[i]);
} 

/* This is basic loop section end */


/* The for in statement start */

const o = {
    a: 1,
    b: 2,
    c: 3,
    d: 4
};

console.log('property: value');
for(p in o){
    console.log(p+': ' + o[p]);
}

/* This is for in statement end */


/* Iterationg over an array element  start */

const o = ['first', 'second', false];

for(p in o){
    console.log(p + ' ' + o[p] );
}


/* Iterationg over an array element  end */


/** The Foreach Method start */

const arr = ['a','b','c','d'];

arr.forEach((value, index, array) => {
    console.log('index', index, 'has a value of', value,
    'which correlates to array[' + index + ']:', array[index]);
});

arr.forEach((value,index) => {
    console.log('index', index, 'has a value of', value);
});

arr.forEach((value) => {
    console.log('value:', value);
});

/** The Foreach Method end */


/** main task code start */
function getCount(objects) {
    var ctr = 0;
    for (var i = 0; i < objects.length; i++){
        if (objects[i].x == objects[i].y) {
            ctr++;
        }
    }
    return ctr;
}
/** main task code ends*/