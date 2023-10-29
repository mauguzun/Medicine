import { Component, OnInit } from '@angular/core';
import { HttpResponse } from "@angular/common/http";
import { FormGroup, FormControl, Validators } from "@angular/forms";
import { Router } from "@angular/router";
import { TranslateService } from "@ngx-translate/core";
import { ApiResponse } from "src/app/shared/models/viewModels/ApiResponse";
import { LoginDto } from "src/app/shared/models/viewModels/Dto/LoginDto";
import { AuthService } from "src/app/shared/services/api/auth.service";
import { NotificationService } from "src/app/shared/services/notification.service";
import { environment } from "src/assets/environments/environment";
import { Sex } from 'src/app/shared/enums/Sex';
import { TimeZone } from 'src/app/shared/enums/Timezone';
import { UserSettingsDto } from 'src/app/shared/models/viewModels/Dto/UserSettingsDto';
import { Language } from 'src/app/shared/enums/Language';
import { SettingsService } from 'src/app/shared/services/api/settings.service';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.css']
})
export class SettingsComponent implements OnInit {

  userSettingsDto: UserSettingsDto
  loader: boolean = false;

  sex = Object.entries(Sex).filter(e => !isNaN(e[0] as any)).map(e => ({ name: e[1], id: e[0] }));
  timezones = Object.entries(TimeZone).filter(e => !isNaN(e[0] as any)).map(e => ({ name: e[1], id: e[0] }));
  languages = Object.entries(Language).filter(e => !isNaN(e[0] as any)).map(e => ({ name: e[1], id: e[0] }));

  form: FormGroup;

  constructor(
    private authService: AuthService,
    private settingService: SettingsService,
    private notification: NotificationService,
    private translate: TranslateService) {

    this.userSettingsDto = this.authService.user ?? new UserSettingsDto(1);

    this.form = new FormGroup({
      Language: new FormControl(this.languages.find(x => x.id === this.userSettingsDto.Language.toString()), [Validators.required]),
      Name: new FormControl(this.userSettingsDto.Name, [Validators.required]),
      TimeZone: new FormControl(this.timezones.find(x => x.id === this.userSettingsDto.TimeZone.toString()), [Validators.required]),
      Sex: new FormControl(this.sex.find(x => x.id === this.userSettingsDto.Sex.toString()), [Validators.required]),
      Birthday: new FormControl(this.userSettingsDto.Birthday, [Validators.required]),
      PhoneNumber: new FormControl(this.userSettingsDto.PhoneNumber, [Validators.required]),
    });

  }

  ngOnInit() { }

  submit() {

    if (this.form.valid) {

      this.loader = true;



      this.form.value.Sex = this.form.value.Sex.id;
      this.form.value.TimeZone = this.form.value.TimeZone.id;
      this.form.value.Language = this.form.value.Language.id;

      const user = new UserSettingsDto(this.userSettingsDto.Id);
      Object.assign(user, this.form.value);

      console.log(user);

      this.settingService.save(user)
        .subscribe((response: HttpResponse<ApiResponse<string>>) => {
          if (response.ok === true) {
            this.notification.show(this.translate.instant('saved'));
          } else if (response.body) {
            this.notification.error(response.body.Message);
          }
        })
    }
  }
}
