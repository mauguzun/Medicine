import { Sex } from "../../enums/Sex";
import { Course } from "./Course";
import { User } from "./User";


export class CourseSettingsDto {
  courseId!: number;
  course!: Course;
  sex: Sex = Sex.male;
  minAge?: number;
  maxAge?: number;
  weight!: number;
  user!: User;
  userId!: number;
  id!: number;
  createdAt?: Date;
}
