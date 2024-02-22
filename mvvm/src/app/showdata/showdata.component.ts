import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-showdata',
  templateUrl: './showdata.component.html',
  styleUrls: ['./showdata.component.css']
})
export class ShowdataComponent implements OnInit {

  posts: any;
  constructor(private userService:UserService) {
  }

  ngOnInit(): void {
   this.getUserData();
  }



    getUserData(){
      const tag="tech";
      this.userService.GetUsers(tag).subscribe(response =>{
      this.posts=response.data;
      },
      (error)=>{

      });
    }


}
