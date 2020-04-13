# Online-Store-Platform-API

---
## Requirments
.NET Framework 4.7.2  
Visual Studio 2012 or higher(required till Docker added)  

---
## API Operations and how to request :-
Options for **Postman** collaboration platform
1. Register
   - Request URL : http://localhost:51642/api/Account/Register
   - HTTP Request Method : **POST**
   - Body
     - JSON Fromat, EX : { "email": "test@gmail.com", "userName": "test", "password": "123456" }
   - Headers 
     - Content-Type : application/json
2. List all registerd users
   - Request URL : http://localhost:51642/api/Admin/getAllUsers
   - HTTP Request Method : **GET**
   - Body 
     - NONE
   - Headers 
     - NONE
3. Login
   - Request URL : http://localhost:51642/api/Account/Login?email=test@gmail.com&password=123456
   - HTTP Request Method : **POST**
   - Body 
     - NONE
   - Headers 
     - NONE
---
