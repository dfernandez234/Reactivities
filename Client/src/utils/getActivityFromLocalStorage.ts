export const getActivityIdFromLocalStorage = () => {
    const activityId = localStorage.getItem("activityId");
    const id = activityId ? JSON.parse(activityId) : null;
    return id;
}

export const addActivityIdToLocalStorage = (activityId:string) => {
    localStorage.setItem('activityId', JSON.stringify(activityId));
};
  
export const removeActivityIdFromLocalStorage = () => {
    localStorage.removeItem('activityId');
};