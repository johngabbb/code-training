import React, { SyntheticEvent } from "react";

interface Props {
  onDeletePortfolio: (e: SyntheticEvent) => void;
  portfolioValue: string;
}

const DeletePortfolio = ({ onDeletePortfolio, portfolioValue }: Props) => {
  return (
    <>
      <form onSubmit={onDeletePortfolio}>
        <input hidden={true} value={portfolioValue} />
        <button type="submit">Delete</button>
      </form>
    </>
  );
};

export default DeletePortfolio;
