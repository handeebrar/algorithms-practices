#include<stdio.h>

int main() {
    
    int i, n;
    float mean1 = 0.0, mean2 = 0.0, mean3 = 0.0;
    
    scanf("%d",&n);
    
    int arr[n];
    
    for(i = 0; i < n; i++) {
        
        scanf("%d",&arr[i]);
        
        if(arr[i] > 0) mean1 = mean1 + (1.0 / n);
        
        else if(arr[i] < 0) mean2 = mean2 + (1.0 / n);
        
        else mean3 = mean3 + (1.0 / n);
        
    }

    printf("%f\n%f\n%f",mean1,mean2,mean3);
    
    return 0;
}

