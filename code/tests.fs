module Tests
open Code;
let helloWorldTest() = 
    Assert.areEqual "Hello World!" (Code.helloWorld())
let capitalizeEveryNthWordTest() =
    let sentence = "Lorem ipsum dolor sit amet";
    Assert.areEqual "Lorem Ipsum dolor Sit amet" (capitalizeEveryNthWord sentence 0 2)
    Assert.areEqual "Lorem ipsum Dolor Sit Amet" (capitalizeEveryNthWord sentence 2 1)
    Assert.areEqual "Lorem ipsum Dolor sit Amet" (capitalizeEveryNthWord sentence 0 2)