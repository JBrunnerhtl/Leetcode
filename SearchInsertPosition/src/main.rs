fn main() {
    println!("Hello, world!");
    let vec_new: Vec<i32> = [1, 3, 4, 5].to_vec();
    let target: i32 = 7;
    println!("{}", search_insert(vec_new, target));
}


pub fn search_insert(nums: Vec<i32>, target: i32) -> i32 {
    let mut new_vec: Vec<i32> = nums.to_vec();
    new_vec.push(target);
    new_vec.sort();
    let position: i32 = new_vec.iter().position(|&x| x == target).unwrap() as i32;
    position
}