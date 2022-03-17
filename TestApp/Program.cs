int[] nums1 = new int[] {1,3};
int[] nums2 = new int[] {2};



int i = 0, i1 = 0, i2 = 0, med_index = (nums1.Length + nums2.Length - 1) / 2;
int temp = 0;
double median;

while(i<=med_index)
{
    if(i1 == nums1.Length)
        temp = nums2[i2++];
    else if (i2 == nums2.Length)
        temp = nums1[i1++];
    else if(nums1[i1] < nums2[i2])
        temp = nums1[i1++];
    else
        temp = nums2[i2++];
    i++;
}

median = (double)temp;

if((nums1.Length + nums2.Length) % 2 == 0)
{
    if(i1 == nums1.Length)
        temp = nums2[i2++];
    else if (i2 == nums2.Length)
        temp = nums1[i1++];
    else if(nums1[i1] < nums2[i2])
        temp = nums1[i1++];
    else
        temp = nums2[i2++];
    median = (median + (double)temp) /2 ;
}

Console.WriteLine(median);
