use std::fs::File; 
use std::io::prelude::*;
use std::string;

fn main() {

    let mut _file = File::open("input1.txt").expect("no file");

    let mut _contents = String::new();

    _file.read_to_string(&mut _contents).expect("can't read file");

    println!("this is content \n\n-------------------------\n {}",_contents);

}


