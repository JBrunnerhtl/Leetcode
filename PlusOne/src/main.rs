fn main() {
    println!("Hello, world!");
    let mut example: Vec<i32> = vec![1,2,3,4,9];
    example = plus_one(example);
    println!("{:?}", example);
}

fn plus_one(digits: Vec<i32>) -> Vec<i32> {
    let mut result: Vec<i32> = digits;
    for i in (0..result.len()).rev()  {
        if(result[i] < 9) {
            result[i] +=1;
            return result;
        }
        result[i] = 0;
    }
    result.insert(0, 1);
    result
}