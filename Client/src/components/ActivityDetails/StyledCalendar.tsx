import React from 'react'
import Calendar from 'react-calendar';
import styled from 'styled-components';

const StyledCalendar = () => {
  return (
    <CalendarContainer>
      <Calendar calendarType='US' />
    </CalendarContainer>
  )
}

const CalendarContainer = styled.div`
  /* ~~~ container styles ~~~ */
  max-width: 100%;
  background-color: #d4f7d4;
  border-radius: 3px;

  .react-calendar{
    width: 100%;
    border: none;
    box-shadow: 0 1px 2px 0 rgba(34, 36, 38,.15);
  }
`;


export default StyledCalendar