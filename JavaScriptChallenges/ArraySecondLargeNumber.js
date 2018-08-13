function getSecondLargest(nums) {
    // Complete the function
    var maxvalue = 0;
    var secmaxvalue = 0;

    for(var i=0; i<nums.length; i++)
    {
        if(nums[i] > maxvalue)
        {
            secmaxvalue = maxvalue;
            maxvalue = nums[i];
        }
        else if(nums[i] > secmaxvalue && nums[i] < maxvalue)
        {
            secmaxvalue = nums[i];        
        }
    }
    return secmaxvalue;
}