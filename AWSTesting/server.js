const express = require("express");
const app= express();
const path = require("path");


app.get("/",function(req, res){
    res.sendFile(path.join(__dirname,"/public/index.html"));
});

app.get("/form", function(req,res){
    res.sendFile(path.join(__dirname,"/public/form.html"));
});

app.listen(3000);

console.log("Port 3000");
