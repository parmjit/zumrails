import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UserResponse } from 'src/models/UserResponse';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http:HttpClient) {

   }

   GetUsers(tag:string):Observable<any> {
    return this.http.get<UserResponse>("https://localhost:7120/Post/GetPosts?tag="+tag);
   }
}
