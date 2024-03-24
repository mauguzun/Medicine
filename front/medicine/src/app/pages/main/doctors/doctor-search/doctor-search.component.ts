import { Component, OnInit } from '@angular/core';
import { Apollo } from 'apollo-angular';
import gql from 'graphql-tag';
import { ReminderDto } from 'src/app/shared/models/entity/ReminderDto';
import { UserResponse } from 'src/app/shared/models/entity/responses/users/UserResponse';
import { GqlResponse } from 'src/app/shared/models/viewModels/ApiResponse';

const getDoctorQuery = gql`
query userFind {
  userFind(where: { role: { eq: MEDICINE_WORKER } })  {
    id
    email
    name
    role
  }
}`;

export class DoctorQueryInterface<T>{
  constructor(public userFind: T) { }
}


@Component({
  selector: 'app-doctor-search',
  templateUrl: './doctor-search.component.html',
  styleUrls: ['./doctor-search.component.css']
})

export class DoctorSearchComponent implements OnInit {


  constructor(private apollo: Apollo) { }

  ngOnInit() {


    this.apollo
      .query<DoctorQueryInterface<UserResponse[]>>({ query: getDoctorQuery })
      .subscribe(({ data  }) => {
       alert(data.userFind[0].email)
      })


  }

}
