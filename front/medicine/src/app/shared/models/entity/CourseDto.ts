import { CourseType } from "../../enums/CourseType";
import { CourseGroupDto } from "./CourseGroupDto";
import { CourseSettingsDto } from "./CourseSettingsDto";
import { DosingFrequencyDto } from "./DosingFrequencyDto";
import { TherapyDto } from "./TherapyDto";
import { TranslatedDto } from "./translate/TranslatedDto";


export class CourseDto {
  therapy!: TherapyDto;
  courseGroup!: CourseGroupDto;
  courseSettings: CourseSettingsDto[] = [];
  dosingFrequencies: DosingFrequencyDto[] = [];
  translations: TranslatedDto[] = [];
  therapyId!: number;
  courseGroupId!: number;
  courseType!: CourseType;
  id!: number;
  createdAt?: Date;
}



