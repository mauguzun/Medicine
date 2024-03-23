import { Component, OnInit } from '@angular/core';
import { Apollo } from 'apollo-angular';
import gql from 'graphql-tag';
import { ReminderDto } from 'src/app/shared/models/entity/ReminderDto';
import { GqlResponse } from 'src/app/shared/models/viewModels/ApiResponse';

@Component({
  selector: 'app-doctor-search',
  templateUrl: './doctor-search.component.html',
  styleUrls: ['./doctor-search.component.css']
})

export class DoctorSearchComponent implements OnInit {

  constructor(private apollo: Apollo) { }

  ngOnInit() {

    this.apollo
    .query<GqlResponse<ReminderDto>>({
      query: gql`
        query find {
          find {
            id
            title
            createdAt
            dosingFrequencyReminders {
              id
              usingDescription
              dosingFrequency {
                id
                total
                translations {
                  title
                  description
                  language
                }
                drug {
                  id
                  title
                  translations {
                    title
                    description
                  }
                  drugCategories {
                    id
                    translations {
                      id
                      title
                      description
                    }
                  }
                }
                course {
                  id
                  translations {
                    id
                    title
                    description
                    language
                  }
                  therapy {
                    id
                    translations {
                      id
                      title
                      description
                    }
                  }
                }
              }
            }
          }
        }
      `,
    })
    .subscribe(({ data }) => {
       alert(data.find)
    })

    alert(1)

  }

}
