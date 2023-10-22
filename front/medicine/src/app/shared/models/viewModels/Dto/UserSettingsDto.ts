import { Role } from "src/app/shared/enums/Role";
import { Language } from "../../../enums/Language";
import { Sex } from "../../../enums/Sex";
import { TimeZone } from "../../../enums/Timezone";



export class UserSettingsDto {

  constructor(UserId: number) {
    this.UserId = UserId
  }

  UserId!: number;
  Language: Language = Language.en;
  Name!: string;
  TimeZone: TimeZone = TimeZone["(UTC) Coordinated Universal Time"];
  Sex: Sex = Sex.male;
  Birthday!: Date;
  PhoneNumber!: string;
  Roles: Role = Role.doctor;
}
