import { Role } from "src/app/shared/enums/Role";
import { Language } from "../../../enums/Language";
import { Sex } from "../../../enums/Sex";
import { TimeZone } from "../../../enums/Timezone";

export class UserSettingsDto {

  constructor(Id: number) {
    this.Id = Id
  }

  Id!: number;
  Language: Language = Language.en;
  Name!: string;
  TimeZone: TimeZone = TimeZone["(UTC) Coordinated Universal Time"];
  Sex: Sex = Sex.male;
  Birthday!: string;
  PhoneNumber!: string;
  Roles: Role = Role.doctor;
}
