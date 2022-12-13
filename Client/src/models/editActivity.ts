import { ActivityFormValues } from "./activity";
import { IActivityCreate } from "./createActivity";

export interface IActivityEdit{
    ActivityId:string | undefined,
    data: ActivityFormValues
}