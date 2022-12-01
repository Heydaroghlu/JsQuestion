var users=[
    {
    name:"Alex",
    email:"sjdksjdkj@gmai.com",
    skills:["HTML","CSS","C#"],
    age:20,
    points:30
},
{
    name:"Tural",
    email:"sjdksjdkj@gmai.com",
    skills:["HTML","CSS","Js"],
    age:20,
    points:30
},
{
    name:"Musa",
    email:"sjdksjdkj@gmai.com",
    skills:["HTML","Js","C#"],
    age:20,
    points:30
}
]
CheckMajor(users);
function CheckMajor(params)
{
    for (let index = 0; index < params.length; index++) {
        let skills=params[index].skills
        let count=0;
        for (let i = 0; i < skills.length; i++) {
            
            if(skills[i]=="Js")
            {
               count++
            }
            if(skills[i]=="C#")
            {
                if(count!=0)
                {
                    count+=3;
                }
               else{
                count+=2
               }
            }
        if(count==1)
        {
            console.log("Fronted Developer "+users[index].name+" "+users[index].email+" "+users[index].age+users[index].points)
        }
        if(count==4)
        {
            console.log("FullStack Developer"+users[index].name+" "+users[index].email+" "+users[index].age+users[index].points)
        }
        if(count==2)
        {
            console.log("Backend Developer "+users[index].name+" "+users[index].email+" "+users[index].age+users[index].points)
        }
        }
        
    }
}