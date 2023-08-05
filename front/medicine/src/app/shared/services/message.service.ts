import { Injectable } from "@angular/core";
import {MatSnackBar, MatSnackBarRef, MatSnackBarModule} from '@angular/material/snack-bar';
import { TranslateService } from "@ngx-translate/core";

@Injectable({
  providedIn: "root",
})
export class MessageService {
  private _settings!: { duration: 3000;};

  constructor(
    private _snackBar: MatSnackBar,
    private translate: TranslateService
  ) {}

  show(message: string): void {
    this._snackBar.open(this.translate.instant(message), undefined, this._settings);
  }

  dialog(message: string): void {
    this._snackBar.open(
      this.translate.instant(message),
      this.translate.instant("agreed"),
      this._settings
    );
  }

  error(error: string, extraMessage = ""): void {
    this._snackBar.open( `${this.translate.instant(error)}${extraMessage}`);
  }

  errorList(errorList: string[], extraMessage = ""): void {
    console.log(errorList);
    // this._snackBar.open(
    //   errorList.join('-'),
    //   null,
    //   null
    // );
  }
}
