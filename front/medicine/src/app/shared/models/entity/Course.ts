import { CourseType } from "../../enums/CourseType";
import { User } from "./User";
import { DosingFrequency } from "./DosingFrequency";
import { Therapy } from "./Therapy";
import { CourseGroup } from "./CourseGroup";
import { CourseSettings } from "./CourseSettings";
import { TranslatedCourse } from "./translate/TranslatedCourse";


export class Course {
  therapyId!: number;
  therapy!: Therapy;
  courseGroup!: CourseGroup;
  courseGroupID!: number;
  courseType!: CourseType;
  courseSettings: CourseSettings[] = [];
  dosingFrequencies: DosingFrequency[] = [];
  translations: TranslatedCourse[] = [];
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
