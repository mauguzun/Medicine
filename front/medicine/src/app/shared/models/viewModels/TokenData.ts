import { Language } from "../../enums/Language";
import { Role } from "../../enums/Role";
import { Sex } from "../../enums/Sex";
import { TimeZone } from "../../enums/Timezone";


export class TokenData {

  Email!: string;
  Id!: number;
  Language: Language = Language.en;
  Name!: string;

  TimeZone: TimeZone = TimeZone["(UTC) Coordinated Universal Time"];
  Role: Role = Role.user;
  Sex: Sex = Sex.male;
  Birthday!: Date;
  PhoneNumber!: string;
}


